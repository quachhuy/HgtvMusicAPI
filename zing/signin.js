const buttons = document.getElementsByClassName('SUbutton');

// Lặp qua từng phần tử trong HTMLCollection và gán sự kiện click cho mỗi phần tử
for (let i = 0; i < buttons.length; i++) {
  buttons[i].addEventListener('click', () => {
    window.location.href = 'signup.html';
  });
}

const login = document.getElementsByClassName('SIbutton');
for (let i = 0; i < login.length; i++) {
  login[i].addEventListener('click', () => {
    window.location.href = 'index.html';
  });
}


