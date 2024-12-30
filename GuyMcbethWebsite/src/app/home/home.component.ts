import { Component, OnInit } from '@angular/core';
import moment from 'moment';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent implements OnInit {
  public duration: string = "";
  public birthdate = new Date(2017, 8, 8, 20, 58, 0, 0);

  ngOnInit(): void {
    this.duration = this.getDurationText();
  }

  private getElapsedDuration(date: Date): moment.Duration {
    const then = moment(date);
    const now = moment();

    const difference = now.diff(then);
    const elapsed = moment.duration(difference);

    return elapsed;
  }

  private pluralize(count: number, text: string): string {
    var result = count + " " + text;

    if (count != 1) {
      result += "s";
    }

    return result;
  }

  private getDurationText() {
    var age = this.getElapsedDuration(this.birthdate);

    var message =
      this.pluralize(Math.floor(age.asYears()), "year") + ", " +
      this.pluralize(age.months(), "month") + ", " +
      this.pluralize(age.days(), "day") + ", " +
      this.pluralize(age.hours(), "hour") + ", and " +
      this.pluralize(age.minutes(), "minute");

    return message;
  }
}
