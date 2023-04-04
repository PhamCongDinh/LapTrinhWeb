// websiteModel = Backbone.Model.extend({
//     default:{
//         "name": "",
//         "age":0,
//         "updateTime": new Date()

//     },
//     initialize: function(){
//         alert("website["+ this.cid + "] :" + JSON.stringify(this));
//     }
// });
// var tmpStaff = new websiteModel();
// tmpStaff.set({name: "Murata", age: 15, id: 101});
 
// console.log("Staff[" + tmpStaff.cid + "]: " + JSON.stringify(tmpStaff));
 
// var tmpStaff2 = new websiteModel({name: "Kenichiro", age: 35, id: 102});


// var Staff = Backbone.Model.extend({
//     defaults: {
//         "name": "",
//         "age": 0,
//         "updateTime": new Date()
//     },
//     initialize: function() {
//         console.log("Staff[" + this.cid + "]: " + JSON.stringify(this));
//     }
// });
 
// var tmpStaff = new Staff();
// tmpStaff.set({name: "Murata", age: 15, id: 101});
 
// console.log("Staff[" + tmpStaff.cid + "]: " + JSON.stringify(tmpStaff));
 
// var tmpStaff2 = new Staff({name: "Kenichiro", age: 35, id: 102});


//events

//On
// var object = {};

// _.extend(object, Backbone.Events);

// object.on("alert", function(msg) {
//   alert("Triggered " + msg);
//   alert("on " + msg);
// });
// object.off();
// object.trigger("alert", "an event");

// book.on({
//     "change:author": authorPane.update,
//     "change:title change:subtitle": titleView.update,
//     "destroy": bookView.remove
//   });
//off


// const myModel = new Backbone.Model();

// // Đăng ký một hàm xử lý cho sự kiện "change" chỉ được gọi một lần duy nhất
// myModel.once('change', () => {
//   console.log('Model changed for the first time!');
// });

// // Thay đổi giá trị của một thuộc tính trong model, sự kiện "change" sẽ được kích hoạt
// myModel.set('name', 'John');

// // Thay đổi giá trị của một thuộc tính trong model lần nữa, sự kiện "change" sẽ không được kích hoạt nữa
// myModel.set('name', 'Smith');


// var artist = new Backbone.Model({
//   firstName: "Wassily",
//   lastName: "Kandinsky"
// });

// artist.set({birthday: "December 16, 1866"});
// alert(artist.get("firstName"));
//  alert(JSON.stringify(artist));


// var collection = new Backbone.Collection([
//   {name: "Tim", age: 5},
//   {name: "Ida", age: 26},
//   {name: "Rob", age: 55}
// ]);
// alert(collection.at(0).get("name"));
// // alert(JSON.stringify(collection));










// var object = new Backbone.Collection;

// object.on("add", function(msg) {
//   alert("Triggered " + msg.get("name"));
// });

// object.add([
//   {name : "abc"}
// ])



// //reset collection
// var TodoItem = Backbone.Model.extend({
//   defaults: {
//     title: "",
//     completed: false
//   }
// });

// var TodoList = Backbone.Collection.extend({
//   model: TodoItem
// });

// var todos = new TodoList([
//   { title: "Task 1", completed: false },
//   { title: "Task 2", completed: true },
//   { title: "Task 3", completed: false }
// ]);
// alert(JSON.stringify(todos));
// var newTodos = [
//   { title: "Task 4", completed: false },
//   { title: "Task 5", completed: true }
// ];

// todos.reset(newTodos);
// alert(JSON.stringify(todos));

// //pluck
// var stooges = new Backbone.Collection([
//   {name: "Curly"},
//   {name: "Larry"},
//   {name: "Moe"}
// ]);

// var names = stooges.pluck("name");

// alert(JSON.stringify(names));





var Router = Backbone.Router.extend({
  routes: {
    "": "home",
    "page1": "page1",
    "page2": "page2",
    "page3/:id": "page3"
  },

  home: function() {
    console.log("Trang chủ");
  },

  page1: function() {
    console.log("Trang 1");
  },

  page2: function() {
    console.log("Trang 2");
  },

  page3: function(id) {
    console.log("Trang 3, id = " + id);
  }
});

var router = new Router();

Backbone.history.start();
