@ModelType IEnumerable(Of KS2WebMVC.Team)

<div class="container body-content">

    <h2 class="owfont-big">Competitive lohkot</h2>

    <h2 class="xtrafont2" style="text-align:left;">Lohko #1</h2>

    <div class="row">


        @For Each item In Model.Where(Function(i) i.Division = 1)
            @<div Class="col-lg-3 col-xs-12 col-sm-6 col-md-4">
                <div Class="panel panel-default">
                    <div Class="panel-heading xtrafont3">
                        <span>@Html.DisplayFor(Function(modelItem) item.CityName)</span>
                        <br />
                        <strong>#@Html.DisplayFor(Function(modelItem) item.TeamName)</strong>
                    </div>
                    <div Class="panel-body xtrafont3">

                        <p>(C): @Html.DisplayFor(Function(modelItem) item.User1.FirstOrDefault.Username)</p>
                        <Table Class="table">

                            @Code
                                If item.User1.Count > 0 Then
                                    For Each itemi In item.User
                                        @<tr>
                                            <td>@Html.DisplayFor(Function(modelItem) itemi.Username)</td>
                                        </tr>
                                    Next
                                End If
                            End Code


                        </Table>
                    </div>
                </div>
            </div>
                                Next
    </div>


    <h2 Class="xtrafont2" style="text-align:left;">Lohko #2</h2>
    <div class="row">

        @For Each item In Model.Where(Function(i) i.Division = 2)
            @<div Class="col-lg-3 col-xs-12 col-sm-6 col-md-4">
                <div Class="panel panel-default">
                    <div Class="panel-heading xtrafont3">
                        <span>@Html.DisplayFor(Function(modelItem) item.CityName)</span>
                        <br />
                        <strong>#@Html.DisplayFor(Function(modelItem) item.TeamName)</strong>
                    </div>
                    <div Class="panel-body xtrafont3">

                        <p>(C): @Html.DisplayFor(Function(modelItem) item.User1.FirstOrDefault.Username)</p>
                        <Table Class="table">

                            @Code
                            If item.User1.Count > 0 Then
                                For Each itemi In item.User
                                        @<tr>
                                            <td>@Html.DisplayFor(Function(modelItem) itemi.Username)</td>
                                        </tr>
                                Next
                            End If
                            End Code


                        </Table>
                    </div>
                </div>
            </div>
                            Next
    </div>

    <hr/>
    <h2 class="owfont-big">Premier lohkot</h2>
    <h2 class="xtrafont2" style="text-align:left;">Lohko #3</h2>

    <div class="row">

        @For Each item In Model.Where(Function(i) i.Division = 3)
    @<div Class="col-lg-3 col-xs-12 col-sm-6 col-md-4">
        <div Class="panel panel-default">
            <div class="panel-heading xtrafont3">
                <span>@Html.DisplayFor(Function(modelItem) item.CityName)</span>
                <br />
                <strong>#@Html.DisplayFor(Function(modelItem) item.TeamName)</strong>
            </div>
            <div Class="panel-body xtrafont3">

                <p>(C): @Html.DisplayFor(Function(modelItem) item.User1.FirstOrDefault.Username)</p>
                <Table Class="table">

                    @Code
                        If item.User1.Count > 0 Then
                            For Each itemi In item.User
                                @<tr>
                                    <td>@Html.DisplayFor(Function(modelItem) itemi.Username)</td>
                                </tr>
                            Next
                        End If
                    End Code


                </Table>
            </div>
        </div>
    </div>
                        Next
</div>



</div>
