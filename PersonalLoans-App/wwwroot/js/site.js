const rateValueInput = document.querySelector("#rate-input");
const rateTypeSelect = document.querySelector("#rate-type");

const personalRate = 22;
const automovilRate = 12;
const mortgageRate = 8;

const GetRate = (option) => {

    if (option === "1") return personalRate;
    if (option === "2") return automovilRate;
    if (option === "3") return mortgageRate;
}

document.addEventListener('DOMContentLoaded', () => {
    rateTypeSelect.onchange = (e) => rateValueInput.value = GetRate(e.target.value) + '%';
});