document.getElementById('btnRedirection').addEventListener('click', function () {
    window.location.href = 'All_News.html';
});
window.addEventListener('DOMContentLoaded', function () {
    var internetBar = document.getElementById('internet-bar');

    function updateInternetBar() {
        if (navigator.onLine) {
            internetBar.style.backgroundColor = 'green';
        } else {
            internetBar.style.backgroundColor = 'red';
        }
    }

    updateInternetBar();

    window.addEventListener('online', updateInternetBar);
    window.addEventListener('offline', updateInternetBar);
});