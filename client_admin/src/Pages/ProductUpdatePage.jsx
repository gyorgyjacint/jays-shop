import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom"
import fetchDataAsync from "../Services/fetchDataAsync";
import { Box, Button, Container, Stack, TextField } from "@mui/material";
import Loading from "../Components/Loading";

export default function ProductUpdatePage(){
    const { id } = useParams();
    const [product, setProduct] = useState(null);
    const [loading, setLoading] = useState(true);
    const navigate = useNavigate();
    
    useEffect(() => {
        if (product == null) {
            fetchDataAsync(`/api/product/getbyid/${id}`)
            .then(d => {
                setProduct(d);
                setLoading(false);
            })
        }
    },[id]);

    const handleSave = (e) => {
        e.preventDefault();
        const data = new FormData(e.currentTarget);
        let jsonContent = {};
        
        for (const property in product) {
            if (Object.hasOwnProperty.call(product, property)) {
                const value = data.get(property);
                if (value != null && value.length > 0) {
                    jsonContent[property] = data.get(property);
                }
            }
        }

        jsonContent["productId"] = product["productId"];
        jsonContent["thumbnailUrl"] = product["thumbnailUrl"];
        jsonContent["picturesUrls"] = product["picturesUrls"];

        const body = JSON.stringify(jsonContent);
        
        fetchDataAsync("/api/product/update", "PATCH", body, {"Content-Type": "application/json"})
        .then(id => {
            if (id === product["productId"]) {
                navigate("/products")
            }
        })
    }

    if (loading) {
        return <Loading />;
    }

    return (
        <Container>
            <Stack
                component="form"
                onSubmit={handleSave}
                sx={{
                    display: "grid",
                    gridRow: 2
                }}
                spacing={2}
                noValidate
                autoComplete="off"
                >
                { getFields(product) }
                <Box sx={{gap: "15px", display: "flex", justifyContent: "center"}}>
                    <Button variant="contained" type="submit">Save</Button>
                    <Button variant="contained" onClick={() => navigate("/products")}>Cancel</Button>
                </Box>
            </Stack>
        </Container>
    );
}

function getFields(product){
    let fields = [];

    for (const property in product) {
        if (Object.hasOwnProperty.call(product, property)) {
            if (property.toLowerCase().includes("url")) {
                continue;
            }

            const value = product[property];
            fields.push(
                <TextField
                disabled={property === "productId"}
                key={property}
                id={property}
                name={property}
                label={property}
                defaultValue={value}
                />
            )
        }
    }

    return fields;
}

