import { RouterProvider, createBrowserRouter } from 'react-router-dom';

import Layout from './Layout';
import LoginPage from './Pages/LoginPage';
import ErrorPage from './Pages/ErrorPage';
import HomePage from './Pages/HomePage';


import './App.css';
import { AuthProvider } from './Services/Authentication/AuthProvider';
import Users from './Pages/UsersPage';
import Products from './Pages/ProductsPage';
import OrdersPage from './Pages/OrdersPage';
import ProductUpdatePage from './Pages/ProductUpdatePage';
import { Box } from '@mui/material';

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
      path: "/update/product/:id",
      element: <ProductUpdatePage />
    },
    {
      path: "/orders",
      element: <OrdersPage />
    }
  ]);

  return (
    <Box sx={{ minWidth: "100%", minHeight: "100vh"}}>
      <Layout />
      <RouterProvider router={router} />
    </Box>
  );
}

export default App;
