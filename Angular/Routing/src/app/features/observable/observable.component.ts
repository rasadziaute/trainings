import { Component, OnInit } from '@angular/core';
import { of, Observable, from } from 'rxjs';

@Component({
  selector: 'app-observable',
  templateUrl: './observable.component.html',
  styleUrls: ['./observable.component.scss']
})
export class ObservableComponent implements OnInit {

  constructor() { }


  ngOnInit(): void {

  const myObservable = from([1, 2, 3, 'string']);

  const myObserver = {
    next: x => console.log('Observer got next value: ' + x),
    error: err => console.error('Observer got an error: ' + err),
    complete: () => console.log('Observer got a complete notification'),
  };
  myObservable.subscribe(myObserver);
  }

}
