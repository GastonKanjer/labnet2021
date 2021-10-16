import { TestBed } from '@angular/core/testing';

import { ShipperlistService } from './shipperlist.service';

describe('ShipperlistService', () => {
  let service: ShipperlistService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShipperlistService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
