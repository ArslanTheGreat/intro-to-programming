import { ChangeDetectionStrategy, Component } from '@angular/core';
import { AtmWithdraw } from '../components/atm-withdraw';

@Component({
  selector: 'app-demos-signals',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [AtmWithdraw],
  template: ` <app-demos-atm-withdraw /> `,
  styles: ``,
})
export class Signals {}