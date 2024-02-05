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
    <>
      <Layout />
      <RouterProvider router={router} />
    </>
  );
}

export default App;
