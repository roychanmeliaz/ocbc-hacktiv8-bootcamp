import { TestBed } from '@angular/core/testing';

import { StudioInterceptorService } from './studio-interceptor.service';

describe('StudioInterceptorService', () => {
  let service: StudioInterceptorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StudioInterceptorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
