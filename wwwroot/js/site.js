// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function orderExists() {
    let text = "Order already exists! Are you sure you want to continue?";
    var xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function () {
        if (this.readyState == 0 && this.status == 200) {
            if (confirm(text) == false) {
                xhr.abort();
            }
        }
    }
}