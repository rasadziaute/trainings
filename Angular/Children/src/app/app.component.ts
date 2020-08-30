import { Component, AfterViewInit, ViewChild, ElementRef, ViewChildren, QueryList } from '@angular/core';
import { CatsComponent } from './features/cats/cats.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements AfterViewInit {
  title = 'Children';
  catName = 'Sushi';
  catName1 = 'Vafles';
  catName2 = 'Cat';
  catName3 = 'Fluffy';

  @ViewChild(CatsComponent) cat: CatsComponent;

  @ViewChild('info') info: ElementRef;

  @ViewChildren(CatsComponent) cats: QueryList<CatsComponent>;

  ngAfterViewInit() {
    console.log('Cat name ', this.cat.catName);
    console.log(this.info.nativeElement.innerHTML);
    this.info.nativeElement.innerHTML = 'Information about a cats name using @ViewChild';
    this.cats.forEach(catNames => console.log(catNames));
  }
}
