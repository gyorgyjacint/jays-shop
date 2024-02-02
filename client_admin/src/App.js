import { RouterProvider, createBrowserRouter } from 'react-router-dom';

import Layout from './Layout';
import ErrorPage from './Pages/ErrorPage';
import HomePage from './Pages/HomePage';

import LoginPage from './Pages/LoginPage';
import ImgTest from './Pages/ImgTest';

import './App.css';
import { AuthProvider } from './Services/Authentication/AuthProvider';
import Users from './Pages/UsersPage';
import Products from './Pages/ProductsPage';
import Orders from './Pages/OrdersPage';

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
    <>
      <Layout />
      <RouterProvider router={router} />
    </>
  );
}

export default App;
