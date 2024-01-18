import { Navigate } from "react-router-dom";
import { useAuth } from "../Services/Authentication/AuthProvider";

export const ProtectedRoute = ({ children }) => {
  const { user } = useAuth() ?? {user:null};
  if (!user) {
    // user is not authenticated
    return <Navigate to="/login" />;
  }
  return children;
};