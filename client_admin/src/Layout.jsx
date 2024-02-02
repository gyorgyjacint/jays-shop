import { Alert, Box, Button, Container } from "@mui/material";
import { useEffect, useState } from "react";
import isLoggedIn from "./Services/isLoggedIn";
import fetchDataAsync from "./Services/fetchDataAsync";

export default function Layout()
{
    const [serverStatus, setServerStatus] = useState(true);
    const [loggedIn, setLoggedIn] = useState(true);
    const [mutation, setMutation] = useState(true);

    const containerStyle = {
        maxWidth: "100%",
        margin: "auto",
        marginTop: "15px",
        marginBottom: "15px",
        display: "flex",
        gap: "8px",
        justifyContent:"center"
    }

    const observer = new MutationObserver((mutationsList) => {
        setMutation(!mutation);
    });
    observer.observe(document.getElementById("root"), { attributes: true, childList: true })

    useEffect(() => {
        isLoggedIn()
        .then(status => {
            setLoggedIn(status === 200);
            if (status === 500) {
                setServerStatus(false);
            }
            if (status !== 200 && window.location.pathname !== "/login") {
                window.location.replace("/login");
            }
        })
    }, [mutation, loggedIn, serverStatus]);

    useEffect(() => {
        fetchDataAsync("/api/authtest/status")
        .then(d => setServerStatus(d.ok))
    }, [])

    if (!serverStatus){
        return <Alert severity="error">Server is down. Please refresh or try again later.</Alert>;
    }

    const handleHomeBtn = () => { window.location.replace("/home") }
    const handleUsersBtn = () => { window.location.replace("/users") }
    const handleProductsBtn = () => { window.location.replace("/products") }
    const handleOrdersBtn = () => { window.location.replace("/orders") }
    const handleLogoutBtn = (e) => { 
        //TODO: how to log out admin (HttpOnly cookie)?
     }

    return (
        <Box backgroundColor="lightslategrey" sx={{display: "flex"}}>
            {loggedIn && 
            <>
                <Container color="lightblue" sx={containerStyle}>
                    <Button variant="contained" onClick={handleHomeBtn} sx={{fontWeight: 600, position: "absolute", left: "20px"}}>Home</Button>
                    <Button variant="contained" onClick={handleUsersBtn}>Users</Button>
                    <Button variant="contained" onClick={handleProductsBtn}>Products</Button>
                    <Button variant="contained" onClick={handleOrdersBtn}>Orders</Button>
                    <Button 
                    style={{fontWeight: 600, position: "absolute", right: "20px"}} 
                    variant="contained"
                    onClick={handleLogoutBtn}
                    >Logout
                    </Button>
                </Container>
            </>
            }
            {!serverStatus && <Alert severity="error">Server is down.</Alert>}
        </Box>
    );
}