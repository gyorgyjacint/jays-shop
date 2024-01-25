import { useEffect, useState } from "react";
import fetchDataAsync from "../Services/fetchDataAsync";
import Loading from "../Components/Loading";

export default function Users(){
    const [products, setProducts] = useState(null);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        fetchDataAsync("/api/product/getall")
        .then(p => {
            setProducts(p);
        })
    }, []);

    if (loading) {
        return <Loading />
    }

    return (
    <div>

    </div>
    );
}