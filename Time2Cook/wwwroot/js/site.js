document.addEventListener('DOMContentLoaded', function () {

    // --- Dropdown checkboxes: toggle open/close ---
    document.querySelectorAll('.dropdown-btn').forEach(function (btn) {
        btn.addEventListener('click', function (e) {
            e.stopPropagation();
            var parent = this.parentElement;
            var isOpen = parent.classList.contains('active');
            // Close all others first
            document.querySelectorAll('.dropdown-checkbox.active').forEach(function (el) {
                el.classList.remove('active');
            });
            if (!isOpen) parent.classList.add('active');
        });
    });

    // --- Close dropdowns when clicking outside ---
    document.addEventListener('click', function () {
        document.querySelectorAll('.dropdown-checkbox.active').forEach(function (el) {
            el.classList.remove('active');
        });
    });

    // --- Close Bootstrap mobile nav when a nav-link is clicked ---
    var navbarCollapse = document.querySelector('.navbar-collapse');
    if (navbarCollapse) {
        navbarCollapse.querySelectorAll('.nav-link, .nav-register-btn').forEach(function (link) {
            link.addEventListener('click', function () {
                if (navbarCollapse.classList.contains('show')) {
                    var toggler = document.querySelector('.navbar-toggler');
                    if (toggler) toggler.click();
                }
            });
        });
    }

});
