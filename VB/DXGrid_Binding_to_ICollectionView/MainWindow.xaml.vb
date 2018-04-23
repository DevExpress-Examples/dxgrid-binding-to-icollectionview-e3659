Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Data
Imports System.ComponentModel

Namespace DXGrid_Binding_to_ICollectionView
	Public Class myData
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateitem As String
		Public Property item() As String
			Get
				Return privateitem
			End Get
			Set(ByVal value As String)
				privateitem = value
			End Set
		End Property
	End Class
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
