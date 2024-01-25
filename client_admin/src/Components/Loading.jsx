import { Container } from '@mui/material';
import './Loading.css';

export default function Loading(){
    const containerStyle = {
        maxWidth: "90%",
        margin: "auto",
        marginTop: "150px",
        display: "flex",
        justifyContent:"center"
    }
    return (
        <Container sx={containerStyle}>
            <div className="loader" />
        </Container>
    );
}