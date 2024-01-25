import { useEffect, useState } from "react";
import fetchDataAsync from "../Services/fetchDataAsync";
import Loading from "../Components/Loading";
import { Box } from "@mui/material";
import { DataGrid } from "@mui/x-data-grid";

export default function Users(){
    const [users, setUsers] = useState(null);
    const [loading, setLoading] = useState(true);

    const columns = [
        { field: "id", headerName: "ID", flex: 1 },
        { field: "userName", headerName: "Username", flex: 1 },
        { field: "email", headerName: "Email", flex: 1 },
        { field: "emailConfirmed", headerName: "Email confirmed", flex: 1 },
        { field: "phoneNumber", headerName: "Phone number", flex: 1 },
        { field: "phoneNumberConfirmed", headerName: "Phone number confirmed", flex: 1 }
    ];

    useEffect(() => {
        fetchDataAsync("/api/user/getall")
        .then(p => {
            setUsers(p);
            setLoading(false);
        })
    }, []);

    if (loading) {
        return <Loading />;
    }

    return (
    <Box maxWidth={"90%"} margin="auto" marginTop="30px" display="flex" justifyContent="center" justifyItems="center" justifySelf="center">
        <DataGrid
            rows={users}
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