document.getElementById("login-form").addEventListener("submit", function (event) {
    event.preventDefault();

    const username = document.getElementById("username").value;
    const password = document.getElementById("password").value;

    if (username === "shahriar" && password === "123") {
        window.location.href = "index.cshtml"; // Replace "another-page.html" with the URL of the page you want to redirect to upon successful login.
    } else {
        const errorMessage = document.getElementById("error-message");
        errorMessage.textContent = "Invalid username or password.";
    }
});
