import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-cats',
  templateUrl: './cats.component.html',
  styleUrls: ['./cats.component.scss']
})
export class CatsComponent implements OnInit {
  @Input() catName: string;

  constructor() { }

  ngOnInit(): void {
  }

}
