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

    Form1 : +lblMaxGrade : Label
    Form1 : +lblMinGrade : Label
    Form1 : +lblGPAx : Label
    Form1 : +lblStudentCount : Label
    Form1 : +txtGrade : TextBox
    Form1 : +lstGrades : ListBox
    Form1 : +btnAddGrade : Button

    Form1 : +grades = List<double>
    Form1 : +btnAddGrade_Click(sender, e)
    Form1 : +UpdateStatistics()

    class Label {
        + Text : string
    }
    
    class TextBox {
        + Text : string
        + Clear()
        + Focus()
    }

    class ListBox {
        + Items : List<string>
        + Add(string)
    }

    class Button {
        + Text : string
        + Click()
    }
