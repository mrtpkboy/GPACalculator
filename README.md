# GPACalculator

## Class Diagram

```mermaid
classDiagram
    class Form1 {
        - List<double> grades
        + Form1()
        + btnAddGrade_Click(sender: Object, e: EventArgs)
        + UpdateStatistics()
    }

    class Label {
        + Text: string
    }

    class TextBox {
        + Text: string
        + Clear()
        + Focus()
    }

    class ListBox {
        + Items: List<string>
        + Add(string)
    }

    class Button {
        + Text: string
        + Click()
    }

    Form1 --|> Label : lblMaxGrade
    Form1 --|> Label : lblMinGrade
    Form1 --|> Label : lblGPAx
    Form1 --|> Label : lblStudentCount
    Form1 --|> TextBox : txtGrade
    Form1 --|> ListBox : lstGrades
    Form1 --|> Button : btnAddGrade
