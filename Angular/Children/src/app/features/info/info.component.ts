import { Component, OnInit, ContentChildren, QueryList, AfterViewInit, AfterContentInit } from '@angular/core';
import { CatsComponent } from '../cats/cats.component';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  styleUrls: ['./info.component.scss']
})
export class InfoComponent implements OnInit, AfterContentInit {
  @ContentChildren(CatsComponent) cats: QueryList<CatsComponent>;

  ngAfterContentInit(): void {
    this.cats.forEach(catNames => console.log(catNames));
  }

  constructor() { }

  ngOnInit(): void {
  }

}
