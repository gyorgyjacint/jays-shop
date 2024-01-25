import { RouterProvider, createBrowserRouter } from 'react-router-dom';

import Layout from './Layout';
import ErrorPage from './Pages/ErrorPage';
import HomePage from './Pages/HomePage';

import LoginPage from './Pages/LoginPage';
import { ProtectedRoute } from './Components/ProtectedRoute';
import ImgTest from './Pages/ImgTest';

import './App.css';
import { AuthProvider } from './Services/Authentication/AuthProvider';
import Users from './Pages/UsersPage';
import Products from './Pages/ProductsPage';
import Orders from './Pages/OrdersPage';
import { Container } from '@mui/material';

function App() {

  const router = createBrowserRouter([
    {
      path: "/",
      element: <HomePage />,
      errorElement: <ErrorPage />
    },
    {
      path: "/login",
      element: (
        <AuthProvider>
          <LoginPage />
        </AuthProvider>
      )
    },
    {
      path: "/home",
      element: <HomePage />
    },
    {
      path: "/users",
      element: <Users />
    },
    {
      path: "/products",
      element: <Products />
    },
    {
      path: "/orders",
      element: <Orders />
    },
    {
      path: "/imgtest",
      element: (
        <ImgTest />
      )
    }
  ]);

  return (
    <Container>
      <Layout />
      <RouterProvider router={router} />
    </Container>
  );
}

export default App;
