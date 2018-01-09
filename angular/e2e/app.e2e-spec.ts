import { StroudwaterIdentityTemplatePage } from './app.po';

describe('StroudwaterIdentity App', function() {
  let page: StroudwaterIdentityTemplatePage;

  beforeEach(() => {
    page = new StroudwaterIdentityTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
