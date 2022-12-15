// import { initializeApp } from 'https://www.gstatic.com/firebasejs/9.15.0/firebase-app.js';
// import * as database from 'https://www.gstatic.com/firebasejs/9.15.0/firebase-database.js';

// import {
//   getDatabase,
//   ref,
//   set,
//   child,
//   update,
//   remove,
//   onValue,
// } from 'https://www.gstatic.com/firebasejs/9.15.0/firebase-database.js';

// const db = getDatabase();
// const issuesRef = ref(db, 'student');

// function readIssues() {
//   onValue(issuesRef, (snapshot) => {
//     snapshot.forEach(snap => {
//       const issue = snap.val();
//       console.log(issue.NameOfStd);
//     })
// });

const getQuestions = () => {
  const firebaseConfig = {
    apiKey: 'AIzaSyBR4a5kpN1jSxMWwyqUlapNZhKX_9v306k',
    authDomain: 'webpr5.firebaseapp.com',
    databaseURL: 'https://webpr5-default-rtdb.firebaseio.com',
    projectId: 'webpr5',
    storageBucket: 'webpr5.appspot.com',
    messagingSenderId: '484360050507',
    appId: '1:484360050507:web:f23d8de6e750004df8face',
    measurementId: 'G-MWR3Q859FJ',
  };

  const app = firebase.initializeApp(firebaseConfig);

  // const database = getDatabase();

  // const ref = ref(database, 'test');

  // console.log(ref);

  return firebase
    .database()
    .ref()
    .child('questions')
    .once('value')
    .then(snap => snap.val());
};

export { getQuestions };
