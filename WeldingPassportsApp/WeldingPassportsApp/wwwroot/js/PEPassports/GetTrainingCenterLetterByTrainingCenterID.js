$(function () {
    $(function () {
        $("#TrainingCenterID").on("change", function () {
            $.getJSON("https://localhost:44315/api/TrainingCentersApi/GetLetterByTrainingCenterId", { id: Number($(this).val()) }, function () { })
                .done(function (data) {
                $("#Letter")[0].innerHTML = data;
            });
        });
    });
});