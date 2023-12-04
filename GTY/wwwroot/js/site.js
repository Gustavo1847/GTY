document.addEventListener('DOMContentLoaded', function () {
    const seletorTema = document.getElementById('seletorTema');
    const imagemTema = document.getElementById('imagemTema');
    const navTema = document.getElementById('navTema');
    const labelTema = document.getElementById('labelTema');
    const dropdownMenuTema = document.getElementById('dropdownMenuTema');
    const htmlElement = document.documentElement;

    // Verificar se há uma preferência de tema salva no localStorage
    const savedTheme = localStorage.getItem('selectedTheme');

    if (savedTheme) {
        applyTheme(savedTheme);

        // Definir o estado do checkbox com base na preferência salva
        seletorTema.checked = savedTheme === 'dark';
    }

    seletorTema.addEventListener('change', function () {
        const selectedTheme = seletorTema.checked ? 'dark' : 'light';
        applyTheme(selectedTheme);

        // Salvar a preferência no localStorage
        localStorage.setItem('selectedTheme', selectedTheme);
    });

    function applyTheme(theme) {
        if (theme === 'dark') {
            document.body.classList.add('dark-mode');
            imagemTema.src = '../imagens/GTY-Logo-Crop-Escuro.png';
            imagemTema.alt = 'Logo GTY Escuro';

            navTema.className = 'navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark border-bottom box-shadow mb-3';

            labelTema.textContent = 'Tema Escuro';
            labelTema.className = 'form-check-label text-light';

            dropdownMenuTema.className = 'dropdown-menu dropdown-menu-dark';

            htmlElement.setAttribute('data-bs-theme', 'dark');
        } else {
            document.body.classList.remove('dark-mode');
            imagemTema.src = '../imagens/GTY-Logo-Crop.png';
            imagemTema.alt = 'Logo GTY Claro';

            navTema.className = 'navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-light border-bottom box-shadow mb-3';

            labelTema.textContent = 'Tema Claro';
            labelTema.className = 'form-check-label text-dark';

            dropdownMenuTema.className = 'dropdown-menu';

            htmlElement.setAttribute('data-bs-theme', 'light');
        }
    }

});