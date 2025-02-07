$(document).ready(function () {
    $("#calculate").click(function () {
        let hours = $("#hours").val();
        let rate = 20;

        if (hours === "" || hours <= 0) {
            alert("Please enter a positive number of hours.");
            $("#total").text("$0");
        } else {
            let totalCost = hours * rate;
            $("#total").text(`$${totalCost.toFixed(2)}`);
        }
    });
});
