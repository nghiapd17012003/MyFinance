const chartCanvas = document.getElementById('budgetPieChart');
var screenWidth = screen.width;
var screenHeight = screen.height;
chartCanvas.parentNode.style.height = (screenHeight / 2) + "px";
chartCanvas.parentNode.style.width = (screenWidth / 3) + "px";

console.log(chartData); // Now chartData will be available

new Chart(chartCanvas, {
    type: 'pie',
    data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
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
