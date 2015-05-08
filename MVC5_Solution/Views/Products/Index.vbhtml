@ModelType IEnumerable(Of MVC5_Solution.Models.Product)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Title)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Remaining)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Price)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Remaining)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Price)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ID })
        </td>
    </tr>
Next

</table>
