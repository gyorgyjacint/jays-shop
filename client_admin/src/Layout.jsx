import { Alert, Button, Container } from "@mui/material";
import { useEffect, useState } from "react";
import isLoggedIn from "./Services/isLoggedIn";
import fetchDataAsync from "./Services/fetchDataAsync";

export default function Layout()
{
    const [serverStatus, setServerStatus] = useState(true);
    const [loggedIn, setLoggedIn] = useState(true);
    const [mutation, setMutation] = useState(true);

    const observer = new MutationObserver((mutationsList) => {
        setMutation(!mutation);
    });
    observer.observe(document.getElementById("root"), { attributes: true, childList: true })

    useEffect(() => {
        isLoggedIn()
        .then(isOk => {
            setLoggedIn(isOk);
            // Component is not part of a Route so useNavigate cannot be used here
            if (!isOk && window.location.pathname !== "/login") {
                window.location.replace("/login");
            }
        })
    }, [mutation, loggedIn]);

    useEffect(() => {
        fetchDataAsync("/api/authtest/status")
        .then(d => setServerStatus(d.ok))
    }, [])

    if (!serverStatus){
        return <Alert severity="error">Server is down.</Alert>;
    }

    function fetchDummyAuth2() {
        fetch("/api/dummy/dummyauth2");
    }

    const handleHomeBtn = () => { window.location.replace("/home") }
    const handleUsersBtn = () => { window.location.replace("/users") }
    const handleProductsBtn = () => { window.location.replace("/products") }
    const handleOrdersBtn = () => { window.location.replace("/orders"); }

    return (
        <div>
            {loggedIn && 
                <Container color="lightblue">
                    <Button variant="contained" onClick={handleHomeBtn}>Home</Button>
                    <Button variant="contained" onClick={handleUsersBtn}>Users</Button>
                    <Button variant="contained" onClick={handleProductsBtn}>Products</Button>
                    <Button variant="contained" onClick={handleOrdersBtn}>Orders</Button>
                </Container>
            }
            {!serverStatus && <Alert severity="error">Server is down.</Alert>}
        </div>
    );
}