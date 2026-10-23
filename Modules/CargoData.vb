Option Strict On
Option Explicit On

Public Structure CargoBooking

    Public BookingID As String
    Public CustomerName As String
    Public Route As String
    Public BookingDate As Date
    Public CargoType As String
    Public WeightKg As Double
    Public RatePerKg As Double
    Public Status As String

End Structure

Module CargoData

    Public Cargo(999) As CargoBooking

    Public RecordCount As Integer = 0

    Public FileLoaded As Boolean = False

    Public DataChanged As Boolean = False
    Public Function CalculateFreight(
    ByVal weight As Decimal,
    ByVal rate As Decimal) As Decimal

        Return weight * rate
    End Function
End Module