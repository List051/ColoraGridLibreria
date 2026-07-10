Il repository contiene:

- il progetto WinForms di esempio  
- il file `Video.html`  
- il riferimento alla libreria NuGet `WinContrGridLib`  
- il Form1 con tutto il codice 

---

# 📘 **README.md — WinContrGridLib Example Project**

```markdown
# WinContrGridLib — Example Project  
Esempio completo di utilizzo della libreria **WinContrGridLib** per la colorazione avanzata dei DataGridView in applicazioni WinForms.

---

## 📦 Librerie utilizzate

Questo progetto dimostra l’uso combinato di:

### ✔ WinContrGridLib  
Libreria NuGet per colorare DataGridView con temi, palette personalizzate, colonne specifiche e reset colori.

### ✔ WinIaoraLib  
Utility grafiche per titoli, centering e gestione form.

### ✔ WinpopUpPlus  
Popup grafici con icone, colori e messaggi contestuali.

---

## 🎯 Obiettivo del progetto

Il progetto mostra:

- Caricamento dati da database in DataGridView  
- Colorazione automatica delle griglie con WinContrGridLib  
- Colorazione personalizzata con temi e palette  
- Evidenziazione colonne specifiche  
- Popup informativi sui pulsanti  
- Caricamento ordini in base al cliente selezionato  
- Esempio di interazione tra più DataGridView  

---

## 🚀 Avvio del progetto

### 1. Installazione libreria NuGet

```powershell
Install-Package WinContrGridLib
```

### 2. Import delle librerie

```vbnet
Imports WinIaoraLib
Imports WinpopUpPlus
Imports WinContrGridLib
```

---

## 📄 Codice del Form di esempio

Il progetto contiene un singolo form (`Form1.vb`) che mostra l’utilizzo reale della libreria.

### ✔ Impostazione titolo e caricamento dati

```vbnet
FrmTitolo.CTitolo(Me, "Esempio di utilizzo Funzioni per DataGrid")

Dim Cquery As String = "select * from clienti"
DataGVLoad.CaricaDGV(ClientiDataGrid, Cquery)
```

### ✔ Popup informativi

```vbnet
PopupHelper.AttachPopup(BtnCercaCliente,
    "Attenzione." & vbCrLf & " Impostato colori per sfondo e testo",
    My.Resources.search_engine,
    Color.Aquamarine,
    Color.Blue)
```

---

## 🔄 Caricamento ordini del cliente selezionato

Quando l’utente seleziona una riga nella griglia clienti:

```vbnet
Private Sub ClientiDataGrid_SelectionChanged(...)
    If ClientiDataGrid.SelectedRows.Count > 0 Then
        CaricaOrdiniPerCliente2()
    End If
End Sub
```

La routine carica gli ordini:

```vbnet
Dim idCliente As Integer =
    Convert.ToInt32(ClientiDataGrid.SelectedRows(0).Cells("IdClienti").Value)

Dim sql As String = "SELECT * FROM Ordini WHERE IdCliOrd = @IdCliOrd"
DataGVLoad.CaricaDGV3(OrdiniDataGrid, sql, parametri, valori, parametri2, valori2)
```

---

## 🎨 Utilizzo della libreria WinContrGridLib

### ✔ Colorazione ciclica

```vbnet
ColoraDgv(OrdiniDataGrid)
```

### ✔ Tema SoftBlu

```vbnet
ColoraDgvModMulti(TemaM.SoftBlu, OrdiniDataGrid)
```

### ✔ Tema Office 2024

```vbnet
ColoraDgvOf24(OrdiniDataGrid, TemaProf.Of24)
```

### ✔ Colonne specifiche

```vbnet
ColoraColonneSpec(OrdiniDataGrid, {1, 3}, Color.Aquamarine, Color.DarkBlue)
```

### ✔ Palette personalizzata (3 colori)

```vbnet
ColoraDgvColorato3((Color.GreenYellow, Color.Azure, Color.AliceBlue), OrdiniDataGrid)
```

### ✔ Colorazione personalizzata con colonne saltate

```vbnet
ColoraDgvCustom(
    OrdiniDataGrid,
    Color.LightBlue,
    ColSpec.Salta,
    Color.LightPink)
```

### ✔ Multi-griglia

```vbnet
ColoraDgvCustomM(
    {Color.Red, ColSpec.Salta, Color.Green},
    OrdiniDataGrid,
    ClientiDataGrid)
```

---

## 🔍 Ricerca clienti

```vbnet
Dim sql As String = "SELECT * FROM Clienti WHERE UPPER(Cliente) LIKE @Cliente"
Dim filtroCliente As String = TxtCercaCliente.Text.Trim().ToUpper()
```

---

## 🎬 Video dimostrativo

Il progetto include un file:

```
Video.html
```

che mostra un’anteprima del funzionamento della libreria.

Puoi aprirlo direttamente dal browser.

---

## 📚 Struttura del progetto

```
Esempio WinContrGridLib/
│
├── Form1.vb
├── Form1.Designer.vb
├── Video.html
├── README.md
└── WinContrGridLib.dll (opzionale)
```

---

## 📄 Licenza

MIT License — libero utilizzo in progetti personali e commerciali.

---

## ✉️ Contatti

Autore: **Ital Pascal**  
Pacchetto NuGet: `https://www.nuget.org/packages/WinContrGridLib` [(nuget.org in Bing)](https://www.bing.com/search?q="https%3A%2F%2Fwww.nuget.org%2Fpackages%2FWinContrGridLib")  
```

---
