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

function EditToolbar(props) {
  const { setRows, setRowModesModel } = props;

  const handleClick = () => {
    const categoryId = 0;
    setRows((oldRows) => [...oldRows, { categoryId, name: '', isNew: true }]);
    setRowModesModel((oldModel) => ({
      ...oldModel,
      [categoryId]: { mode: GridRowModes.Edit, fieldToFocus: 'name' },
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

export default function CategoryPage() {
  const [categories, setCategories] = useState([]);
  const [rowModesModel, setRowModesModel] = useState({});
  const [loading, setLoading] = useState(true);
  const [showErrorSnackbar, setShowErrorSnackbar] = useState(false);
  const [showDeletedSnackbar, setShowDeletedSnackbar] = useState(false);

  useEffect(() => {
    console.log(categories)
  })

  useEffect(() => {
    setLoading(true);
    fetchDataAsync("api/category/getall")
    .then(data => {
      setCategories(data);
      setLoading(false);
    })
  }, []);

  const handleRowEditStop = (params, event) => {
    if (params.reason === GridRowEditStopReasons.rowFocusOut) {
      event.defaultMuiPrevented = true;
    }
  };

  const handleEditClick = (id) => () => {
    setRowModesModel({ ...rowModesModel, [id]: { mode: GridRowModes.Edit } });
  };

  const handleSaveClick = (id) => () => {
    setRowModesModel({ ...rowModesModel, [id]: { mode: GridRowModes.View } });
  };

  const handleDeleteClick = (id) => () => {
    fetchDataAsync(`api/category/delete/${id}`, "DELETE")
    .then(resId => {
      if (resId === id) {
        setCategories(categories.filter((row) => row.categoryId !== resId));
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

    const editedRow = categories.find((row) => row.categoryId === id);
    if (editedRow.isNew) {
      setCategories(categories.filter((row) => row.categoryId !== id));
    }
  };

  const processRowUpdate = (newRow) => {
    const updatedRow = { ...newRow, isNew: newRow.categoryId === 0 };
    if (updatedRow.isNew) {
      newRow.categoryId = null;
    }

    return fetchDataAsync("api/category/update", "PATCH", JSON.stringify(newRow), {"Content-Type": "application/json"})
    .then(id => {
      if (id){
        newRow.categoryId = id;
        setCategories(categories.map(row => row.categoryId === id ? updatedRow : row));//!!
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
    { field: 'categoryId', headerName: 'ID', width: 180, flex: 1 },
    { field: 'name', headerName: 'Name', width: 180, editable: true, flex: 1 },
    {
      field: 'actions',
      type: 'actions',
      headerName: 'Actions',
      width: 100,
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
            onClick={handleEditClick(params.id)}
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

  if (loading || !categories) {
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
        rows={categories}
        getRowId={(row) => row?.categoryId}
        columns={columns}
        editMode="row"
        rowModesModel={rowModesModel}
        onRowModesModelChange={handleRowModesModelChange}
        onRowEditStop={handleRowEditStop}
        processRowUpdate={processRowUpdate}
        slots={{
          toolbar: EditToolbar,
        }}
        slotProps={{
          toolbar: { setRows: setCategories, setRowModesModel },
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
          key={"categorypage-snackbar-error-1"}
      >
        <SnackbarContent 
          style={{backgroundColor: "red", margin: "auto", display:"flex", justifyContent: "center", fontWeight: 530, fontSize: 16}}
          message={
          <div>
            <p>Something went wrong, please try again.</p>
            {"(Name already exists?)"}
          </div>
          }
        />
      </Snackbar>
      <Snackbar 
          anchorOrigin={{ vertical: "bottom", horizontal: "center" }}
          open={showDeletedSnackbar}
          onClose={() => setShowDeletedSnackbar(false)}
          autoHideDuration={3000}
          key={"categorypage-snackbar-deleted-1"}
      >
        <Alert severity="info">Deleted</Alert>
      </Snackbar>
    </Box>
  );
}