import { Component , OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  
  title = '[ Angular - Code Cheat Sheet ]';

  ngOnInit(): void {
    console.log("This Angular is apart of the Code Cheat Sheet project");
  }

}
