import fetchDataAsync from "./fetchDataAsync";

export default function isLoggedIn(){
    return fetchDataAsync("api/AuthTest/AdminAuthorizedStatus")
            .then(d => d.ok)
}