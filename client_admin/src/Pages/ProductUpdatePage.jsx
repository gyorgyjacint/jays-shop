import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import fetchDataAsync from "../Services/fetchDataAsync";
import {
  Box,
  Button,
  Container,
  Grid,
  IconButton,
  ImageList,
  ImageListItem,
  TextField,
  Tooltip,
} from "@mui/material";
import Loading from "../Components/Loading";
import { GridDeleteIcon } from "@mui/x-data-grid";

const inputStyle = {
  backgroundColor: "white",
  borderRadius: "5px"
}

export default function ProductUpdatePage() {
  const { id } = useParams();
  const [product, setProduct] = useState(null);
  const [loading, setLoading] = useState(true);
  const [productNameModel, setProductNameModel] = useState({});
  const [thumbnailPreview, setThumbnailPreview] = useState(null);
  const [imgsPreview, setImgsPreview] = useState(null);
  const navigate = useNavigate();

  useEffect(() => {
    if (product == null) {
      fetchDataAsync(`/api/product/getbyid/${id}`)
      .then((d) => {
        setProduct(d);
        setLoading(false);
      });
    }
  }, [id, product]);

  useEffect(() => {
    if (product == null) {
      return;
    }

    const pModel = {};

    for (const property in product) {
      if (Object.hasOwnProperty.call(product, property)) {
        pModel[property] = getPropNameToDisplay(property);
      }
    }

    setProductNameModel(pModel);
  }, [product]);

  const handleSave = (e) => {
    e.preventDefault();
    const data = new FormData(e.currentTarget);

    data.append("productId", product["productId"]);
    data.append("thumbnailUrl", product["thumbnailUrl"] ?? null);

    if (product["picturesUrls"] != null) {
      for (const url of product["picturesUrls"]) {
        data.append("picturesUrls", url)
      }
    }

    fetchDataAsync("/api/product/update", "PATCH", data)
    .then((id) => {
      if (id === product["productId"]) {
        navigate("/products");
      }
    });
  };

  const handleDeleteImage = (source) => {
    let productData = structuredClone(product);
    const index = productData["picturesUrls"].indexOf(source);

    if (index > -1) {
      productData["picturesUrls"].splice(index, 1);
    }

    setProduct(productData);
  };

  const handleDeleteThumbnail = () => {
    let productData = structuredClone(product);
    productData["thumbnailUrl"] = null;
    setProduct(productData);
  };

  const handleThumbnailUpload = (e) => { setThumbnailPreview(URL.createObjectURL(e.target.files[0])) }
  const handleImageUpload = (e) => {
    let res = [];
    for (let i = 0; i < e.target.files.length; i++) {
      res.push(URL.createObjectURL(e.target.files[i]))
    }
    setImgsPreview(res) 
  }

  if (loading) {
    return <Loading />;
  }

  return (
    <Container>
      <Grid
        container
        direction={"column"}
        component="form"
        onSubmit={handleSave}
        sx={{
          gap: "15px",
          columnCount: 3,
        }}
        spacing={2}
        autoComplete="off"
      >
        <TextField
          sx={inputStyle}
          disabled={true}
          key={"productId"}
          name={"productId"}
          label={productNameModel["productId"]}
          defaultValue={product["productId"]}
        />
        <TextField
          sx={inputStyle}
          key={"name"}
          name={"name"}
          label={productNameModel["name"]}
          defaultValue={product["name"]}
          required
        />
        <TextField
          sx={inputStyle}
          key={"brand"}
          name={"brand"}
          label={productNameModel["brand"]}
          defaultValue={product["brand"]}
          required
        />
        <TextField
          sx={inputStyle}
          key={"price"}
          name={"price"}
          label={productNameModel["price"]}
          defaultValue={product["price"]}
          type="number"
          required
        />
        <TextField
          sx={inputStyle}
          key={"discountPrice"}
          name={"discountPrice"}
          label={productNameModel["discountPrice"]}
          defaultValue={product["discountPrice"]}
          type="number"
        />
        <TextField
          sx={inputStyle}
          key={"color"}
          name={"color"}
          label={productNameModel["color"]}
          defaultValue={product["color"]}
        />
        <TextField
          sx={inputStyle}
          key={"category"}
          name={"category"}
          label={productNameModel["category"]}
          defaultValue={product["category"]}
        />
        <TextField
          sx={inputStyle}
          key={"description"}
          name={"description"}
          label={productNameModel["description"]}
          defaultValue={product["description"]}
          required
        />
        <TextField
          sx={inputStyle}
          key={"productDescriptions"}
          name={"productDescriptions"}
          label={productNameModel["productDescriptions"]}
          defaultValue={product["productDescriptions"]}
        />
        <TextField
          sx={inputStyle}
          key={"productNumber"}
          name={"productNumber"}
          label={productNameModel["productNumber"]}
          defaultValue={product["productNumber"]}
          type="number"
        />
        <TextField
          sx={inputStyle}
          key={"quantity"}
          name={"quantity"}
          label={productNameModel["quantity"]}
          defaultValue={product["quantity"]}
          type="number"
          required
        />
        {product["thumbnailUrl"] && (
          <Box
            sx={{
              maxWidth: 500,
              maxHeight: 450,
              alignContent: "center",
              alignSelf: "center",
            }}
            key={"thumbnailUrl"}
            name={"thumbnailUrl"}
            label={productNameModel["thumbnailUrl"]}
            defaultValue={product["thumbnailUrl"]}
          >
            <img
              id="thumbnail-preview"
              src={product["thumbnailUrl"]}
              alt="Thumbnail"
              height={"100%"}
              width={"100%"}
              loading="lazy"
            />
            <Tooltip
              title="Delete"
              onClick={handleDeleteThumbnail}
              sx={{ position: "absolute" }}
            >
              <IconButton>
                <GridDeleteIcon />
              </IconButton>
            </Tooltip>
          </Box>
        )}
        {product["picturesUrls"] && (
          <ImageList
            key={"picturesUrls"}
            name={"picturesUrls"}
            defaultValue={product["picturesUrls"]}
            sx={{
              width: 500,
              height: "auto",
              alignContent: "center",
              alignSelf: "center",
            }}
            cols={3}
            rowHeight={164}
          >
            {product["picturesUrls"]?.map((source) => (
              <ImageListItem key={source}>
                <img src={source} alt={source} loading="lazy" />
                <Box sx={{ position: "absolute" }}>
                  <Tooltip
                    title="Delete"
                    onClick={() => handleDeleteImage(source)}
                  >
                    <IconButton>
                      <GridDeleteIcon />
                    </IconButton>
                  </Tooltip>
                </Box>
              </ImageListItem>
            ))}
          </ImageList>
        )}
        <Box display={"flex"} margin={"auto"} gap={"50px"}>
          <Button variant="contained" component="label">
            {product["thumbnailUrl"] ? "Change" : "Add"} thumbnail (.jpg, .jpeg, .png only)
            <input
              onChange={handleThumbnailUpload}
              accept=".jpg, .jpeg, .png"
              name="thumbnailNew"
              style={{ display: 'none' }}
              id="thumbnail-button-file"
              type="file"
              />
          </Button>
          <Button variant="contained" component="label">
            Add images (.jpg, .jpeg, .png only)
            <input
              onChange={handleImageUpload}
              accept=".jpg, .jpeg, .png"
              name="picturesNew"
              style={{ display: 'none' }}
              id="images-button-file"
              multiple
              type="file"
              />
          </Button>
        </Box>

        <Box
          sx={{
            gap: "15px",
            display: "flex",
            justifyContent: "center",
            padding: "15px",
          }}
        >
          <Button variant="contained" type="submit">
            Save
          </Button>
          <Button variant="contained" onClick={() => navigate("/products")}>
            Cancel
          </Button>
        </Box>
      </Grid>
      {thumbnailPreview && (
          <Box
          sx={{
            backgroundColor: "greenyellow",
            padding: "2px",
            maxWidth: 500,
            maxHeight: 450,
            margin: "auto",
            alignContent: "center",
            alignSelf: "center",
          }}
          key={"thumbnailPreview"}
          name={"thumbnailPreview"}
          defaultValue={product["thumbnailPreview"]}
        >
          <img
            id="thumbnail-preview"
            src={thumbnailPreview}
            alt="Thumbnail"
            height={"100%"}
            width={"100%"}
            loading="lazy"
          />
          <Tooltip
            title="Delete"
            onClick={()=> {console.log("todo")}}
            sx={{ position: "absolute" }}
          >
            <IconButton>
              <GridDeleteIcon />
            </IconButton>
          </Tooltip>
        </Box>
      )}
          {imgsPreview && (
          <ImageList
            key={"imgsPreview"}
            defaultValue={imgsPreview}
            sx={{
              width: 500,
              height: "auto",
              alignContent: "center",
              alignSelf: "center",
              margin: "auto"
            }}
            cols={3}
            rowHeight={164}
          >
            {imgsPreview?.map((source) => (
              <ImageListItem key={source} sx={{backgroundColor: "greenyellow", padding: "2px", gap: "5px", margin: "6px"}}>
                <img src={source} alt={source} loading="lazy" />
                <Box sx={{ position: "absolute"}}>
                  <Tooltip
                    title="Delete"
                    onClick={() => console.log("todo")}
                  >
                    <IconButton>
                      <GridDeleteIcon />
                    </IconButton>
                  </Tooltip>
                </Box>
              </ImageListItem>
            ))}
          </ImageList>
        )}
    </Container>
  );
}

function getPropNameToDisplay(str) {
  return str
    .split(/(?=[A-Z])/)
    .map((word) => word[0].toUpperCase() + word.substr(1))
    .join(" ");
}
