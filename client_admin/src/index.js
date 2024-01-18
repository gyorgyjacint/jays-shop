import React from 'react';
import ReactDOM from 'react-dom/client';
import { RouterProvider, createBrowserRouter } from 'react-router-dom';
import reportWebVitals from './reportWebVitals';

import App from './App';
import Layout from './Layout';
import ErrorPage from './Pages/ErrorPage';
import HomePage from './Pages/HomePage';

import './index.css';
import LoginPage from './Pages/LoginPage';

const router = createBrowserRouter([
  {
    path: "/",
    element: (
        <HomePage />

    ),
    errorElement: <ErrorPage />
  },
  {
    path: "/login",
    element: <LoginPage />
  },
  {
    path: "/app",
    element: (
        <App />

    )
  }
]);

ReactDOM.createRoot(document.getElementById('root')).render(
    <React.StrictMode>
        <Layout />
        <RouterProvider router={router} />
    </React.StrictMode>
);

reportWebVitals();
