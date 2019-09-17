// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const dropDown = document.getElementById("typeForm");
dropDown.addEventListener("change", (e) => {

    if (e.target.value === "1") {
        const sizeDiv = document.getElementById("sizes");
        sizeDiv.classList.remove("hide");
    }

    if (e.target.value !== "1") {
        const sizeDiv = document.getElementById("sizes");
        sizeDiv.classList.add("hide");
    }
})