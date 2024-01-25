import React, { useEffect, useState } from 'react';
import Avatar from '@mui/material/Avatar';
import Button from '@mui/material/Button';
import CssBaseline from '@mui/material/CssBaseline';
import TextField from '@mui/material/TextField';
import FormControlLabel from '@mui/material/FormControlLabel';
import Checkbox from '@mui/material/Checkbox';
import Link from '@mui/material/Link';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Container from '@mui/material/Container';
import { createTheme, ThemeProvider } from '@mui/material/styles';
import { useNavigate } from 'react-router-dom';
import { useAuth } from '../Services/Authentication/AuthProvider';

const defaultTheme = createTheme();

export default function LoginPage(){
  const [isLoggingIn, setIsLoggingIn] = useState(false);
  const [isLoginInvalid, setIsLoginInvalid] = useState(false);
  const [email, setEmail] = useState("");
  const [remember, setRemember] = useState(false);
  const navigate = useNavigate();
  const authContext = useAuth();

  const emailKeyLocalStorage = "mail";

  useEffect(() => {
    const storedEmail = localStorage.getItem(emailKeyLocalStorage);
    if (storedEmail?.length > 0){
      setEmail(storedEmail);
    }
  }, [])

  const handleSubmit = (event) => {
      event.preventDefault();
      setIsLoggingIn(true);
      const data = new FormData(event.currentTarget);
      const loginData = JSON.stringify({
        email: data.get("email"), 
        password: data.get("password") 
      });

      fetch("/api/auth/authenticateAdmin", {
        method: "POST",
        headers: {
          "Content-Type": "application/json"
        },
        body: loginData,
      })
      .then(res => {
        if(res.status !== 200){
          setIsLoginInvalid(true);
        }
        return res.json();
      })
      .then(data => {
        authContext.login(data.userName);
        if (data.token) {
          setIsLoginInvalid(false);
        }
        navigate("/");
      })
      .finally(() => {
        setIsLoggingIn(false);
      });
    };

    function handleRememberMe(e){
      setRemember(e.target.checked);
      // TODO
      if (remember){
        localStorage.setItem(emailKeyLocalStorage, email);
      } else {
        localStorage.removeItem(emailKeyLocalStorage);
      }
    }

    function handleEmailInput(e){
      setEmail(e.target.value);
    }
  
    return (
      <ThemeProvider theme={defaultTheme}>
        <Container component="main" maxWidth="xs">
          <CssBaseline />
          <Box
            sx={{
              marginTop: 8,
              display: 'flex',
              flexDirection: 'column',
              alignItems: 'center',
              
            }}
          >
            <Avatar sx={{ m: 1, bgcolor: 'secondary.main' }}>
              
            </Avatar>
            <Typography component="h1" variant="h5">
              Sign in
            </Typography>
            <Box component="form" onSubmit={handleSubmit} noValidate sx={{ mt: 1 }}>
              <TextField
                margin="normal"
                required
                fullWidth
                id="email"
                label="Email Address"
                name="email"
                autoComplete="email"
                autoFocus
                onChange={handleEmailInput}
                defaultValue={email}
              />
              <TextField
                margin="normal"
                required
                fullWidth
                name="password"
                label="Password"
                type="password"
                id="password"
                autoComplete="current-password"
              />
              <FormControlLabel
                control={<Checkbox value="remember" color="primary" />}
                label="Remember me"
                onChange={handleRememberMe}
                defaultChecked={!!email}
              />
              <Button
                type="submit"
                fullWidth
                variant="contained"
                sx={{ mt: 3, mb: 2 }}
                disabled = {isLoggingIn}
              >
                Sign In
              </Button>
              <Link href="#" variant="body2">
                  Forgot password?
              </Link>
            </Box>
          </Box>
          {/*isLoggingIn && */}
        </Container>

      </ThemeProvider>
    );
}