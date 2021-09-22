﻿Module TextAndLiteralConstants


    ' Labeling for smart tags
    ' If you want another language, you just have to translate the texts.
    Public Const KPlcPropertiesCategory = "PLC"
    Public Const KPlcAdressingCategory = "PLC Addressing"
    Public Const KSliderCategory = "Slider characteristics"
    Public Const KChartCategory = "Chart characteristics"
    Public Const KPlcFolderCategory = "Folder characteristics"
    Public Const KPlcFormCategory = "Form Characteristics"

    Public Const KPlcComboBoxCategory = "ComboBox characteristics"
    Public Const KPlcPictureBoxCategory = "PictureBox characteristics"
    Public Const KPlcLedCategory = "Led characteristics"
    Public Const KPlcButtonCategory = "Button characteristics"
    Public Const KPlcNumberLabel = "PLC N#"
    Public Const KPlcMaximumValue = "Maximum Value"
    Public Const KPlcMinimumValue = "Minimum Value"
    Public Const KPlcOrientation = "Orientation"
    Public Const KPlcReadOnly = "Read Only"
    Public Const KPlcButtonType = "Button behavior"
    Public Const KPLC_SerieColor = "Serie color"
    Public Const KPLC_SerieNumber = "Serie Number"
    Public Const KPlcDataAreaLabel = "Data Area"
    Public Const KPlcDBLabel = "DB N#"
    Public Const KPlcByteLabel = "Byte N#"
    Public Const KPlcWordsLength = "N# of words"
    Public Const KPlcAlarmsFile = "Alarms file"
    Public Const KPlcSelectAlarmsFile = "Select Alarms file"
    Public Const KPlcCustomItems = "Items"
    Public Const KPlcSliderMax = "Max. Value"
    Public Const KPlcSliderMin = "Min. Value"
    Public Const KPlcSliderOrientation = "Orientation"
    Public Const KPlcItemsLabel = "ComboBox List"
    Public Const KPlcBitLabel = "Bit N#"
    Public Const KPlcBitPictureTrue = "Picture when true"
    Public Const KPlcBitPictureFalse = "Picture when false"
    Public Const KPlcBorderStyle = "Border Style"
    Public Const KErrorReadingFile = "Error reading the alarms file:"
    Public Const KPlcShapetypeLabel = "Shape type"
    Public Const KPlcTrueValueLabel = "Color if true"
    Public Const KPlcFalseValueLabel = "Color if false"
    Public Const KFilterLabel = "Filter"
    Public Const KPlcValueTypeLabel = "Value Type"
    Public Const KPlcDataTypeLabel = "Data Type"
    Public Const KSaveFolder = "Folder"
    Public Const KExtensionFile = "File extension"
    Public Const KPlcButtonTypeLabel = "Write '1' only if pressed"
    Public Const KPlcButtonCaption = "Button Text"
    Public Const KPlcLengthLabel = "STR Length"
    Public Const KPLC_SerieName = "Serie Name"
    Public Const KPLC_SerieAxisType = "Axis Type"
    Public Const KPLC_SerieActive = "Serie Active"
    Public Const KPLC_RegisterNumbers = "Number of points"
    Public Const KPLC_ChartDashStyle = "Chart Style"
    Public Const KPLC_AxisXStep = "Interval Time (ms)"
    Public Const KPLC_TimeInterval = "Step in X axis"
    Public Const KPLC_SerieXAxis = "X Axis"
    Public Const KPLC_SerieYAxis = "Y Axis"
    Public Const KPLC_SerieYAxis2 = "Y2 Axis"
    Public Const KPlcPLC_TimeInterval = "Time Interval"
    Public Const KPLC_YAxis = "Y Axis Name"
    Public Const KPLC_YAxis2 = "Y2 Axis Name"

    Public Const KPLC_XAxis = "X Axis Name"
    Public Const KPLC_XAxisStep = "X Axis Step"

    Public Const KPlcTypeTriggerLabel = "Define the type of trigger"
    Public Const KPlcReferenceValueLabel = "Define the value to be compared to"
    Public Const KPlcFormActive = "This contros is used in a form"
    Public Const KPlcFormNumber = "Form N#"
    Public Const KPlcKeyboard = "Use screen keyboard"
    Public Const KPlcLoadForm = "Loading Form"
    Public Const KPlcShapeType = "Shape type"
    Public Const KPlcColorTrue = "Color True"
    Public Const KPlcColorFalse = "Color False"
    Public Const KPlcColorActive = "Color Active Alarm"
    Public Const KPlcColorAck = "Color Ack Alarm"
    Public Const KPlcColorClosed = "Color Closed Alarm"
    Public Const KLogAlarmsActive = "Activate alarm log"

    Public Const KPlcTipPlcNumber = "Number of PLC configured"
    Public Const KPlcTipDataArea = "Type of PLC Area: inputs, outputs, marks or DB"
    Public Const KFolderSaveTip = "Folder where the form data will be stored"
    Public Const KFolderLog = "Folder where logs will be stored"
    Public Const KFileAlarm = "File with text alarms"

    Public Const KFolderLoadTip = "Button is used for loading data instead of saving data"
    Public Const KSaveLabel = "RECIPE NAME"
    Public Const KLoadLabel = "RECIPE LIST"
    Public Const KDataSaved = "Data saved!"
    Public Const KFolderNotExist = "Folder does not exist."

    Public Const KExtensionTip = "Extension for stored data file."
    Public Const KSelectFolder = "Select Log folder"
    Public Const KPlcTipDataType = "Type of data: integers, reals, strings, chars..."
    Public Const KPlcTipPlcDB = "In case of using DB, number of the DB"
    Public Const KPlcTipPlcByte = "Byte in which variable is set"
    Public Const KPlcTipPLC_Maximum = "Maximum Value"
    Public Const KPlcTipPLC_Minimum = "Minimum Value"
    Public Const KPlcTipComboboxItems = "ComboBox string items"
    Public Const KPlcTipPlcBit = "Bit for boolean variable"
    Public Const KPlcTipPlcFormActive = "The control is used in a form"
    Public Const KPlcTipPlcFormNumber = "The number of the form where is used"
    Public Const KPlcTipPictureBoxTrue = "Picture for true value"
    Public Const KPlcTipPictureBoxFalse = "Picture for false value"
    Public Const KPlcTipBorderStyle = "Border style"

    Public Const KShowPictureFalseAsDefault = "Show false picture as default"
    Public Const KShowPictureTrueAsDefault = "Show true picture as default"

    Public Const KPlcTipShapeType = "Shape type for led"
    Public Const KPlcTipTrueValue = "Color for true value"
    Public Const KPlcTipFalseValue = "Color for false value"
    Public Const KPlcTipButtonType = "Button behavior"
    Public Const KPlcTipCaptionType = "Caption"

    Public Const KPlcTipStrLength = "Max. Length of the string (max characters)"

    'General Text
    Public Const KErrorConnectingToPLC1 = "Impossible to connect to PLC: "
    Public Const KRequestRetry = ". Retry the connection?"
    Public Const KErrorConnectionTitle = "Connection error"
    Public Const KErrorIntroducingValue = "Error introducing value."
End Module
