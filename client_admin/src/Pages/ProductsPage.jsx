import { useEffect, useState } from "react";
import fetchDataAsync from "../Services/fetchDataAsync";
import Loading from "../Components/Loading";
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import AddIcon from '@mui/icons-material/Add';
import EditIcon from '@mui/icons-material/Edit';
import DeleteIcon from '@mui/icons-material/DeleteOutlined';
import SaveIcon from '@mui/icons-material/Save';
import CancelIcon from '@mui/icons-material/Close';
import {
  GridRowModes,
  DataGrid,
  GridToolbarContainer,
  GridActionsCellItem,
  GridRowEditStopReasons,
} from '@mui/x-data-grid';
import { Alert, Snackbar, SnackbarContent } from "@mui/material";
import { useNavigate } from "react-router-dom";

function EditToolbar(props) {
    const { setRows, setRowModesModel } = props;
  
    const handleClick = () => {
      const id = 0;
      setRows((oldRows) => [...oldRows, { id, name: '', age: '', isNew: true }]);
      setRowModesModel((oldModel) => ({
        ...oldModel,
        [id]: { mode: GridRowModes.Edit, fieldToFocus: 'name' },
      }));
    };
  
    return (
      <GridToolbarContainer>
        <Button color="primary" startIcon={<AddIcon />} onClick={handleClick}>
          Add record
        </Button>
      </GridToolbarContainer>
    );
  }

export default function ProductsPage() {
    const navigate = useNavigate();
    const [products, setProducts] = useState([]);
    const [rowModesModel, setRowModesModel] = useState({});
    const [loading, setLoading] = useState(true);
    const [showErrorSnackbar, setShowErrorSnackbar] = useState(false);
    const [showDeletedSnackbar, setShowDeletedSnackbar] = useState(false);
  
    useEffect(() => {
      setLoading(true);
      fetchDataAsync("api/product/getall")
      .then(data => {
        setProducts(data);
        setLoading(false);
      })
    }, []);
  
    const handleRowEditStop = (params, event) => {
      if (params.reason === GridRowEditStopReasons.rowFocusOut) {
        event.defaultMuiPrevented = true;
      }
    };
  
    const handleSaveClick = (id) => () => {
      setRowModesModel({ ...rowModesModel, [id]: { mode: GridRowModes.View } });
    };
  
    const handleDeleteClick = (id) => () => {
      fetchDataAsync(`api/product/delete/${id}`, "DELETE")
      .then(resId => {
        if (resId === id) {
          setProducts(products.filter((row) => row.productId !== resId));
          setShowDeletedSnackbar(true);
        } else {
          setShowErrorSnackbar(true);
        }
      })
    };
  
    const handleCancelClick = (id) => () => {
      setRowModesModel({
        ...rowModesModel,
        [id]: { mode: GridRowModes.View, ignoreModifications: true },
      });
  
      const editedRow = products.find((row) => row.productId === id);
      if (editedRow.isNew) {
        setProducts(products.filter((row) => row.productId !== id));
      }
    };
  
    const processRowUpdate = (newRow) => {
      const updatedRow = { ...newRow, isNew: false };
      return fetchDataAsync("api/product/update", "PATCH", JSON.stringify(newRow), {"Content-Type": "application/json"})
      .then(id => {
        console.log(id)
        console.log(newRow)
        if (id === newRow.productId){
          setProducts(products.map((row) => (row.productId === newRow.productId ? updatedRow : row)));
          return updatedRow;
        } else {
          setShowErrorSnackbar(true);
        }
      })
      
    };
  
    const handleRowModesModelChange = (newRowModesModel) => {
      setRowModesModel(newRowModesModel);
    };
  
    const columns = [
      { field: "productId", headerName: "ID", flex: 1 },
      { field: 'name', headerName: 'Name', width: 180, editable: true },
      {
        field: 'price',
        headerName: 'Price',
        type: 'string',
        width: 180,
        align: 'left',
        headerAlign: 'left',
        editable: true,
        flex: 1
      },
      {
        field: 'discountPrice',
        headerName: 'Discount Price',
        type: 'string',
        width: 180,
        editable: true,
        flex: 1
      },
      {
        field: 'quantity',
        headerName: 'Quantity',
        width: 250,
        editable: true,
        type: 'number',
        flex: 1
      },
      {
        field: 'brand',
        headerName: 'Brand',
        width: 180,
        editable: true,
        type: 'string',
        flex: 1
      },
      {
        field: 'category',
        headerName: 'Category',
        width: 180,
        editable: true,
        type: 'string',
        flex: 1
      },
      {
        field: 'color',
        headerName: 'Color',
        width: 180,
        editable: true,
        type: 'string',
        flex: 1
      },
      {
        field: 'description',
        headerName: 'Description',
        width: 180,
        editable: true,
        type: 'string',
        flex: 1
      },
      {
        field: 'productNumber',
        headerName: 'Product Number',
        width: 180,
        editable: true,
        type: 'number',
        flex: 1
      },
      {
        field: 'actions',
        type: 'actions',
        headerName: 'Actions',
        width: 50,
        flex: 1,
        cellClassName: 'actions',
        getActions: (params) => {
          const isInEditMode = rowModesModel[params.id]?.mode === GridRowModes.Edit;
  
          if (isInEditMode) {
            return [
              <GridActionsCellItem
                icon={<SaveIcon />}
                label="Save"
                sx={{
                  color: 'primary.main',
                }}
                onClick={handleSaveClick(params.id)}
              />,
              <GridActionsCellItem
                icon={<CancelIcon />}
                label="Cancel"
                className="textPrimary"
                onClick={handleCancelClick(params.id)}
                color="inherit"
              />,
            ];
          }
  
          return [
            <GridActionsCellItem
              icon={<EditIcon />}
              label="Edit"
              className="textPrimary"
              onClick={() => navigate(`/update/product/${params.id}`)}
              color="inherit"
            />,
            <GridActionsCellItem
              icon={<DeleteIcon />}
              label="Delete"
              onClick={handleDeleteClick(params.id)}
              color="inherit"
            />,
          ];
        },
      },
    ];
  
    if (loading) {
      return <Loading />;
    }
  
    return (
      <Box  
        sx={{
          maxWidth: "90%",
          height: "fit-content",
          width: '100%',
          margin: "auto",
          marginTop: "10px",
          display: "flex",
          justifyContent: "center",
          justifyItems: "center",
          justifySelf: "center",
         '& .actions': {
            color: 'text.secondary',
          },
          '& .textPrimary': {
            color: 'text.primary',
          },
        }}
      >
        <DataGrid 
          rows={products}
          columns={columns}
          editMode="row"
          rowModesModel={rowModesModel}
          onRowModesModelChange={handleRowModesModelChange}
          onRowEditStop={handleRowEditStop}
          processRowUpdate={processRowUpdate}
          getRowId={(x) => x.productId}
          slots={{
            toolbar: EditToolbar,
          }}
          slotProps={{
            toolbar: { setRows: setProducts, setRowModesModel },
          }}
          initialState={{
            pagination: {
                paginationModel: {page: 0, pageSize: 15}
            }
          }}
          pageSizeOptions={[5, 10, 15, 25, 50, 100]}
        />
        <Snackbar 
            anchorOrigin={{ vertical: "bottom", horizontal: "center" }}
            open={showErrorSnackbar}
            onClose={() => setShowErrorSnackbar(false)}
            autoHideDuration={3000}
            key={"userspage-snackbar-error-1"}
        >
          <SnackbarContent 
            style={{backgroundColor: "red", margin: "auto", display:"flex", justifyContent: "center", fontWeight: 530, fontSize: 16}}
            message={<p>Something went wrong, please try again.</p>}
          />
        </Snackbar>
        <Snackbar 
            anchorOrigin={{ vertical: "bottom", horizontal: "center" }}
            open={showDeletedSnackbar}
            onClose={() => setShowDeletedSnackbar(false)}
            autoHideDuration={3000}
            key={"userspage-snackbar-deleted-1"}
        >
          <Alert severity="info">Deleted</Alert>
        </Snackbar>
      </Box>
    );
  }
