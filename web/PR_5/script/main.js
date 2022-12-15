import { getQuestions } from './api.js';

const openModalButton = document.querySelector('#btnOpenModal');
const modal = document.querySelector('#modalBlock');
const closeModal = document.querySelector('#closeModal');
const questionTitle = document.querySelector('#question');
const formAnswers = document.querySelector('#formAnswers');
const nextButton = document.querySelector('#next');
const prevButton = document.querySelector('#prev');
const sendButton = document.querySelector('#send');

let questions = [];
let page = 0;
let finalAnswers = { additional: [] };
let numberQuestion = null;

const classDBlock = 'd-block';
const classDNone = 'd-none';

closeModal.addEventListener('click', onCloseModalClick);
openModalButton.addEventListener('click', onOpenModalButtonClick);
nextButton.addEventListener('click', onNextButtonClick);
prevButton.addEventListener('click', onPrevButtonClick);
sendButton.addEventListener('click', onSendButtonClick);

getQuestions()
  .then(data => {
    console.log(data);
    questions = data;
  })
  .catch(error => {
    console.error(error);
  });

function onOpenModalButtonClick() {
  modal.classList.add(classDBlock);
  playTest();
}

function onCloseModalClick() {
  modal.classList.remove(classDBlock);
}

function playTest() {
  formAnswers.innerHTML = '';
  sendButton.classList.add(classDNone);

  if (page === 0) {
    prevButton.classList.add(classDNone);
  }
  if (page > 0) {
    prevButton.classList.remove(classDNone);
  }

  if (page === questions.length) {
    nextButton.classList.add(classDNone);
    prevButton.classList.add(classDNone);
    sendButton.classList.remove(classDNone);
    formAnswers.innerHTML = `
       <div class="form-group">
       <label for="numberPhone">Введіть свій номер телефону</label>
       <input id="numberPhone" type="tel" name="phone" required>
       </div>
      `;
    questionTitle.textContent = '';
    page = 0;
    return;
  }

  if (page < questions.length) {
    nextButton.classList.remove(classDNone);
  }

  const renderAnswers = (answersArr, type, category) => {
    answersArr.forEach(answer => {
      const answerItem = document.createElement('div');
      answerItem.classList.add('answers-item', 'd-flex', 'justify-content-center');

      answerItem.innerHTML = `
      <input type="${type}" id="${answer.title}" name="${category}" class="d-none" value="${answer.title}" />
         <label for="${answer.title}" class="d-flex flex-column justify-content-between">
             <img class="answerImg" src="${answer.url}" alt="burger" />
             <span>${answer.title}</span>
         </label>
      `;

      formAnswers.appendChild(answerItem);
    });
  };

  const renderQuestions = index => {
    numberQuestion = index;
    questionTitle.textContent = `${questions[index].question}`;

    renderAnswers(questions[index].answers, questions[index].type, questions[index].category);
  };

  renderQuestions(page);
}

function checkAnswer() {
  const inputs = [...formAnswers.elements].filter(
    element => element.checked || element.id === 'numberPhone'
  );

  inputs.forEach(input => {
    if (input.id === 'numberPhone') {
      finalAnswers.phoneNumber = input.value;
      return;
    }

    if (input.name === 'additional') {
      finalAnswers.additional.push(input.value);
      return;
    }

    finalAnswers[input.name] = input.value;
  });
}

function onNextButtonClick() {
  checkAnswer();
  page += 1;
  playTest();
}

function onPrevButtonClick() {
  page -= 1;
  playTest();
}

function onSendButtonClick() {
  checkAnswer();
  formAnswers.textContent = 'Дякую за пройдений тест';

  sendButton.classList.add(classDNone);
  setTimeout(() => {
    modal.classList.remove(classDBlock);
  }, 2000);

  console.log(finalAnswers);

  firebase.database().ref().child('contacts').push(finalAnswers);

  finalAnswers = { additional: [] };
}
