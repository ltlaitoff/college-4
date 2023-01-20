# Independent Work Weather

## Технічне завдання

### Технології

- Vite
- Vue 3, Vue-router
- Pinia
- Vitest, vue-test-utils
- JavaScript, TypeScript
- Axios

### Header

Зробити "Логотип" в вигляді надпису "Weather". При кліці на логотип виконується перехід на головну сторінку.

Зробити меню, яке буде відцентроване та має пункти "Home" та "Add City"

### Home page

#### Форма виробу міста

Вибір міста зі збереженого сховища. Якщо збережених міст немає - за замовчуванням стоїть пункт "Геолокація за координатами"

Також в формі повина бути кнопка для переходу до іншої сторінки, на якій буде додавання міст до сховища

Показувати результат нище форми
В результаті вивести максимальну кількість необходної інформації

### AddCity page

На сторінці повина бути форма в яку користувач буде вводити назву міста, а через деякий час (~500ms) йому будуть показуватись результати, які знайшлись нище форми.

В формі повина бути кнопка обнулення та кнопка, яка додає місто в сховище по першому першому показаному результату, а користувачу показувати, що було успішно додано.

При нажаті на результат дані його повині записуватись в сховище, а користувачу показувати, що було успішно додано.

## Recommended IDE Setup

## Customize configuration

See [Vite Configuration Reference](https://vitejs.dev/config/).

## Project Setup

```sh
npm install
```

### Compile and Hot-Reload for Development

```sh
npm run dev
```

### Type-Check, Compile and Minify for Production

```sh
npm run build
```

### Run Unit Tests with [Vitest](https://vitest.dev/)

```sh
npm run test:unit
```

### Lint with [ESLint](https://eslint.org/)

```sh
npm run lint
```
