import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-custom-pipes',
  templateUrl: './custom-pipes.component.html',
  styleUrls: ['./custom-pipes.component.scss']
})
export class CustomPipesComponent implements OnInit {

constructor() { }

  sentence: string;
  value: number;
  power: number;


  ngOnInit(): void {
  }

}
