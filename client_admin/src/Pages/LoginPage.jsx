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
import isLoggedIn from '../Services/isLoggedIn';
import { Alert, Backdrop, CircularProgress, Snackbar } from '@mui/material';
import ErrorIcon from '@mui/icons-material/Error';

const defaultTheme = createTheme();

export default function LoginPage(){
  const emailKeyLocalStorage = "mail";
  const [isLoggingIn, setIsLoggingIn] = useState(false);
  const [showInvalidLoginSnackbar, setShowInvalidLoginSnackbar] = useState(false);
  const [isRememberMe, setIsRememberMe] = useState(localStorage.getItem(emailKeyLocalStorage) !== null);
  const [email, setEmail] = useState(localStorage.getItem(emailKeyLocalStorage));
  const navigate = useNavigate();
  const authContext = useAuth();

  useEffect(() => {
    const storedEmail = localStorage.getItem(emailKeyLocalStorage);
    if (storedEmail?.length > 0){
      setEmail(storedEmail);
    }

    isLoggedIn()
    .then(statusCode => {
      if (statusCode === 200){
        navigate("/home")
      }
    });
  }, [navigate])

  const handleSubmit = (event) => {
      event.preventDefault();
      setIsLoggingIn(true);
      const data = new FormData(event.currentTarget);

      if (isRememberMe) {
        localStorage.setItem(emailKeyLocalStorage, data.get("email"))
      }

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
          setShowInvalidLoginSnackbar(true);
        }
        return res.json();
      })
      .then(data => {
        if (data.userName?.length > 0) {
          authContext.login(data.userName);
          setShowInvalidLoginSnackbar(false);
          navigate("/");
        }
      })
      .finally(() => {
        setIsLoggingIn(false);
      });
    };

    function handleRememberMe(e){
      setIsRememberMe(e.target.checked);
      // TODO
      if (e.target.checked){
        localStorage.setItem(emailKeyLocalStorage, email);
      } else {
        localStorage.removeItem(emailKeyLocalStorage);
      }
    }

    function handleEmailInput(e){
      if (isRememberMe) {
        localStorage.setItem(emailKeyLocalStorage, e.target.value)
      }
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
                control={<Checkbox defaultChecked={isRememberMe} color="primary" />}
                label="Remember me"
                onChange={handleRememberMe}
                defaultChecked={email}
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
          
          <Backdrop
            sx={{ color: '#fff', zIndex: (theme) => theme.zIndex.drawer + 1 }}
            open={isLoggingIn}
          >
            <CircularProgress color="inherit" />
          </Backdrop>
          <Snackbar
            anchorOrigin={ { vertical: "top", horizontal: "center" } }
            open={showInvalidLoginSnackbar}
            onClose={() => setShowInvalidLoginSnackbar(false)}
            key={"loginpage-snackbar1"}
          >
            <Alert  icon={<ErrorIcon />} severity='error'>Bad credentials.</Alert>
          </Snackbar>
        </Container>
      </ThemeProvider>
    );
}