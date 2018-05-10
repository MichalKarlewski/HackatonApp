// Write your Javascript code.
document.addEventListener("DOMContentLoaded", function (event) {
    $('#register-debtor').on('submit', function (e) {
        e.preventDefault();
        console.log($(this));
        var debtorData = $(this).serialize();
        console.log(debtorData);
    });
});

