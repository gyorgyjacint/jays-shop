import { useEffect, useState } from "react";
import fetchDataAsync from "../Services/fetchDataAsync";
import { Box, Container } from "@mui/material";
import { DataGrid } from "@mui/x-data-grid";
import Loading from "../Components/Loading";

export default function Products(){
    const [products, setProducts] = useState(null);
    const [loading, setLoading] = useState(true);

    const columns = [
        { field: "productId", headerName: "ID", flex: 1 },
        { field: "name", headerName: "Name", flex: 1 },
        { field: "price", headerName: "Price", flex: 1 },
        { field: "discountPrice", headerName: "Discount Price", flex: 1 },
        { field: "quantity", headerName: "Quantity", flex: 1 },
        { field: "brand", headerName: "Brand", flex: 1 },
        { field: "category", headerName: "Category", flex: 1 },
        { field: "color", headerName: "Color", flex: 1 },
        { field: "description", headerName: "Desc", flex: 1 },
        { field: "productDescriptions", headerName: "ProdDescs", flex: 1 },
        { field: "productNumber", headerName: "Product Number", flex: 1 },
    ];

    useEffect(() => {
        fetchDataAsync("/api/product/getall")
        .then(p => {
            setProducts(p);
            console.log(p[0])
            setLoading(false);
        })
    }, []);

    if (loading) {
        return <Loading />;
    }

    return (
    <Box maxWidth={"90%"} margin="auto" marginTop="30px" display="flex" justifyContent="center" justifyItems="center" justifySelf="center">
        <DataGrid
            rows={products}
            getRowId={(p) => p.productId}
            columns={columns}
            initialState={{
                pagination: {
                    paginationModel: {page: 0, pageSize: 15}
                }
            }}
            pageSizeOptions={[5, 10, 15, 25, 50, 100]}
            checkboxSelection
        />
    </Box>
    );
}