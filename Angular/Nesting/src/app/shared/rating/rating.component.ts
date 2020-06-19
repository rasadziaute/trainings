import { Component, OnInit, OnChanges, Input } from '@angular/core';

@Component({
  selector: 'app-rating',
  templateUrl: './rating.component.html',
  styleUrls: ['./rating.component.scss']
})
export class RatingComponent implements OnInit, OnChanges {
  @Input() rating: number;
  skillRating: string;

  constructor() { }

  ngOnChanges() {
    if (this.rating < 3.5)
    {
      this.skillRating = 'Meh';
    }
    else if (this.rating === 3.5 || this.rating < 4)
    {
      this.skillRating = 'Good';
    }
    else if (this.rating === 4 || this.rating < 5)
    {
      this.skillRating = 'Very Good';
    }
    else if (this.rating === 5)
    {
      this.skillRating = 'Excellent';
    }
    else
    {
      this.skillRating = 'No Rating Specified';
    }

  }

  ngOnInit(): void {
  }

}
