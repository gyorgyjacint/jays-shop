import { useEffect, useState } from "react";
import fetchDataAsync from "../Services/fetchDataAsync";
import Loading from "../Components/Loading";
import { Box, Button, Dialog, DialogActions, DialogTitle, PopoverRoot } from "@mui/material";
import { DataGrid } from "@mui/x-data-grid";

export default function Users(){
    const [users, setUsers] = useState(null);
    const [loading, setLoading] = useState(true);
    const [showDeletePopup, setShowDeletePopup] = useState(false);
    const [selectedUser, setSelectedUser] = useState(null);

    const columns = [
        { field: "userName", headerName: "Username", flex: 1 },
        { field: "email", headerName: "Email", flex: 1 },
        { field: "emailConfirmed", headerName: "Email confirmed", flex: 1 },
        { field: "phoneNumber", headerName: "Phone number", flex: 1 },
        { field: "phoneNumberConfirmed", headerName: "Phone number confirmed", flex: 1 },
        {
            field: "action",
            headerName: "Action",
            renderCell: (params) => {
                const onClick = (e) => {
                    e.preventDefault();
                    setSelectedUser(params.row);
                    setShowDeletePopup(true);
                }

                if (params.row.userName.toLowerCase().includes("admin")) {
                    return undefined;
                }

                return <Button sx={{color: "red"}} onClick={onClick}>Delete</Button>
            }
        }
    ];

    useEffect(() => {
        fetchDataAsync("/api/user/getall")
        .then(p => {
            setUsers(p);
            setLoading(false);
        })
    }, []);

    const handleDelete = () => {
        const result = fetchDataAsync(`/api/user/delete/${selectedUser.id}`);
        if (result) {
            setShowDeletePopup(false);
            const newUsers = users.filter(u => u.id !== selectedUser.id);
            setSelectedUser(null);
            setUsers(newUsers);
        }
    }

    if (loading) {
        return <Loading />;
    }

    return (
    <Box maxWidth={"90%"} margin="auto" marginTop="30px" display="flex" justifyContent="center" justifyItems="center" justifySelf="center">
        <DataGrid
            rows={users}
            columns={columns}
            getRowId={(row) => row.id}
            initialState={{
                pagination: {
                    paginationModel: {page: 0, pageSize: 15}
                }
            }}
            pageSizeOptions={[5, 10, 15, 25, 50, 100]}
        />
        <Dialog
            open={showDeletePopup}
        >
            <DialogTitle id="delete-alert-dialog" sx={ {padding: "30px", paddingBottom: 0, justifyItems: "center", margin: "auto"} }>
                Delete user?
            </DialogTitle>
            <DialogActions sx={ {gap: "25px", padding: "30px"} }>
                <Button onClick={handleDelete} variant="contained" sx={ {backgroundColor: "red"} }>DELETE</Button>
                <Button onClick={() => setShowDeletePopup(false)} variant="contained">BACK</Button>
            </DialogActions>
        </Dialog>
    </Box>
    );
}