export default async function fetchDataAsync(endpoint, method = "GET", body = undefined, headers = undefined) {
    const response = await fetch(endpoint, {
        method,
        body,
        headers: {
            ...headers
        }
    });

    const contentType = response.headers.get("Content-Type");

    if (response.status < 200 || response.status > 299) {
        return false;
    }

    if (contentType == null) {
        return response;
    }

    if (contentType.startsWith("text/plain")) {
        const data = await response.text();
        return data;
    }

    if (contentType.startsWith("application/json")) {
        const data = await response.json();
        return data;
    }
    
    return null;
}