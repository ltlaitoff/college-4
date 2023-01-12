export default {
	title: 'НА ПОДІЇ МИШІ І КЛАВІАТУРИ',
	tasks: [
		{
			id: 1,
			score: 2,
			desription:
				'Виведіть координати миші щодо блоку в момент руху курсора миші всередині блоку. Координати виводити під блоком.',
			completed: true
		},
		{
			id: 2,
			score: 2,
			desription:
				'Створіть блок div, як зображення фону встановіть йому зображення закритої папки. Додайте подію, яка виконується при подвійному натисканні на блоці і замінює фон блоку на зображення відкритої папки',
			completed: true
		},
		{
			id: 3,
			score: 2,
			desription:
				'Додайте в документ 300-400 блоків div квадратної форми з розмірами сторін 30px, і кольором фону. Додавання елементів виконайте за допомогою циклу. Додайте подія при наведенні миші, яке буде скруглять дані блоки за допомогою border-radius до кола. Для уповільнення ефекту заокруглення в CSS можна додати transition.',
			completed: true
		},
		{
			id: 4,
			score: 2,
			desription:
				'Створіть div розмірами ширина - 100%, висота 250px. Нижче додайте 4-5 зображень з однаковими класами, різного розміру. Додайте подію, яка буде при кліку на зображення встановлювати його фоном блоку div з властивістю background-size: contain.',
			completed: true
		},
		{
			id: 5,
			score: 2,
			desription:
				'Створіть блок розмірами 50x50px. Додайте подію кліка, так, що під час кожного кліка на блоці він відсувається на 100px вниз від попереднього положення.',
			completed: true
		},
		{
			id: 6,
			score: 2,
			desription:
				'Створіть кнопку. При натисканні на кнопку за допомогою елемента this виведіть текст, який знаходиться на кнопці. Висновок здійснювати за допомогою alert. Примітка: <button> Саме цей текст виводіть </button>. Нагадаю, що отримати даний текст можна за допомогою this.innerHTML.',
			completed: true
		},
		{
			id: 7,
			score: 2,
			desription:
				'Створіть елементи div, p, button, a. Використовуючи target при натисканні виведіть інформацію про тип елемента на якому клікнули.',
			completed: true
		},
		{
			id: 8,
			score: 2,
			desription: 'Змінити розмір зображення при натисканні миші',
			completed: true
		},
		{
			id: 16,
			score: 2,
			desription:
				'Додайте в html код зображення. Додайте скрипт, який буде виконувати такі дії: при наведенні миші на картинку, зображення буде замінюватися іншим зображенням. При виході миші за межі зображення, буде відновлюватися початкове зображення.',
			completed: true
		},
		{
			id: 17,
			score: 2,
			desription:
				'Використовуючи код з першого завдання, зробіть збільшення зображення*??* при наведенні миші на 40%. Після виходу миші за межі зображення - воно відновлює свої розміри.',
			completed: true
		},
		{
			id: 18,
			score: 3,
			desription:
				'Використовуючи подія onclick реалізувати аналог fancybox. При кліці - картинка збільшується в розмірах і спливає над контентом. Решта контент затемнюється. Для «спливання» зображення використовуйте position: absolute.',
			completed: true
		}
	]
}