
function updateTable() {
    let name = document.getElementById("studentName").value;
    document.getElementById("nameTable").textContent=name;
    let studentId = document.getElementById("studentId").value;
    document.getElementById("idTable").textContent=studentId;
    let score1 = document.getElementById("score1").value;
    document.getElementById("score1Table").textContent=score1;
    let score2 = document.getElementById("score2").value;
    document.getElementById("score2Table").textContent=score2;
    let score3 = document.getElementById("score3").value;
    document.getElementById("score3Table").textContent=score3;

    let totalScore = parseInt(score1) + parseInt(score2) + parseInt(score3)
    document.getElementById("totalScore").textContent = totalScore;

    let percentageScore = (totalScore * 100) / 30;
    document.getElementById("percentageScore").textContent = percentageScore;

    if (parseInt(percentageScore) >=50) {
        document.getElementById("verdict").textContent = "Student passed in distinction";
        document.getElementById("verdict").style.fontWeight = "bold"
    }
    else {
        document.getElementById("verdict").textContent = "Student failed";
        document.getElementById("verdict").style.color = "red";
        document.getElementById("verdict").style.fontWeight = "bold"
    }
}