import { Button, Container } from "@mui/material";

export default function Layout()
{
    return (
        <div>
            <Container color="lightblue">
                <Button variant="contained">Hello1</Button>
                <Button variant="contained">Hello2</Button>
                <Button variant="contained">Hello3</Button>
                <Button variant="contained">Hello4</Button>
            </Container>
        </div>
    );
}