const chartCanvas = document.getElementById('budgetPieChart');
var screenWidth = screen.width;
var screenHeight = screen.height;
chartCanvas.parentNode.style.height = (screenHeight / 2) + "px";
chartCanvas.parentNode.style.width = (screenWidth / 3) + "px";

console.log(chartData); // Now chartData will be available
const lables = Object.keys(chartData);
const dataValues = Object.values(chartData);

new Chart(chartCanvas, {
    type: 'pie',
    data: {
        labels: lables,
        datasets: [{
            label: "Expenses",
            data: dataValues,
            borderWidth: 0.2
        }]
    },
    options: {
        maintainAspectRatio: false,
        responsive: true,
        layout: {
            padding: 20 
        }
    }
});
