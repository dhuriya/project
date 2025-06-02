//Common JavaScript Event Listeners:
//Click
//1 Double Click
//2 Mouseover / Mouseout
//3 Mousemove
//4 Keydown / Keyup
//5 Focus / Blur
//6 Change
//7 Submit
//8 Load
//9 Resize
//10 Scroll
//11 Contextmenu (right-click)
//12 Input

// 🔹 UI Events
// Event	Description
// load	Fires when page is fully loaded
// resize	Fires when window is resized
// scroll	Fires on scrolling
// unload	Fires when page is unloading
// error	Fires when a resource fails to load

// 🔹 Mouse Events
// Event	Description
// click	Single mouse click
// dblclick	Double click
// mousedown	Mouse button pressed
// mouseup	Mouse button released
// mouseenter	Mouse enters element (no bubbling)
// mouseleave	Mouse leaves element (no bubbling)
// mousemove	Mouse movement
// mouseover	Mouse over element (bubbles)
// mouseout	Mouse out of element (bubbles)
// contextmenu	Right click

// 🔹 Keyboard Events
// Event	Description
// keydown	Key is pressed
// keypress	(Deprecated) Key is pressed (character keys)
// keyup	Key is released

// 🔹 Form Events
// Event	Description
// submit	Form is submitted
// change	Form element value is changed
// input	User input (real-time)
// focus	Element gains focus
// blur	Element loses focus
// reset	Form is reset

// 🔹 Clipboard Events
// Event	Description
// copy	Content copied
// cut	Content cut
// paste	Content pasted

// 🔹 Drag & Drop Events
// Event	Description
// drag	Element is dragged
// dragstart	Start dragging
// dragend	Finished dragging
// dragenter	Drag enters a drop target
// dragleave	Drag leaves a drop target
// dragover	Dragging over a drop target
// drop	Dropped on target

// 🔹 Media Events
// Event	Description
// play	Media starts playing
// pause	Media is paused
// ended	Playback ends
// volumechange	Volume is changed
// timeupdate	Time position updates

const card = document.querySelector('.card');
card.addEventListener('click' , () => {
    console.log("card");
});

// 1 Click
const click = document.querySelector('#clickBtn');
click.addEventListener('click', () => {
    alert('Button clicked!');
});
//2 Double click
const dbclick = document.querySelector('#dbClickBtn');
click.addEventListener('click', () => {
    alert('Double clicked!');
});
//3 mouseover/mouseout
const hoverBox = document.querySelector('#hoverBox');
hoverBox.addEventListener('mouseover' , () => {
    hoverBox.style.backgroundColor = 'lightblue';
});
hoverBox.addEventListener('mouseout' , () => {
    hoverBox.style.backgroundColor = '';
});
// Mousemove
const moveBox = document.querySelector('#moveBox');
moveBox.addEventListener('click', (e) => {
    this.textContent = `Mouse at (${e.offsetX}, ${e.offsetY})`;
});
// 5 keydown / keyup
document.querySelector('keydown' , (e) => {
    console.log(`Key down: ${e.key}`);
});
document.querySelector('keyup' , (e) => {
    console.log(`Key up: ${e.key}`);
});

// 6. Focus / Blur
const focusInput = document.getElementById('focusInput');
focusInput.addEventListener('focus', () => console.log('Input focused'));
focusInput.addEventListener('blur', () => console.log('Input blurred'));

 // 7. Change (for select)
 document.getElementById('selectBox').addEventListener('change', function() {
    alert(`Selected: ${this.value}`);
  });

  // 8. Submit
  document.getElementById('sampleForm').addEventListener('submit', function(e) {
    e.preventDefault(); // Prevent real submission
    alert('Form submitted!');
  });

  // 9. Load
  window.addEventListener('load', function() {
    console.log('Page fully loaded');
  });
  // 10. Resize
  window.addEventListener('resize', function() {
    console.log(`Window resized to ${window.innerWidth}x${window.innerHeight}`);
  });

  // 11. Scroll
  document.getElementById('scrollBox').addEventListener('scroll', function() {
    console.log('Scrolled inside box');
  });
  // 12. Contextmenu
  document.addEventListener('contextmenu', function(e) {
    e.preventDefault();
    alert('Right click disabled on this page!');
  });
  // 13. Input (realtime)
  document.getElementById('inputBox').addEventListener('input', function(e) {
    console.log(`Input value: ${e.target.value}`);
  });